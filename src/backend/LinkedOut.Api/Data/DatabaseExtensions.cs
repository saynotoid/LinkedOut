using Microsoft.EntityFrameworkCore;

namespace LinkedOut.Api.Data
{
    public static class DatabaseExtensions
    {
        public static async Task ApplyGlobalRlsAsync(this Microsoft.EntityFrameworkCore.Infrastructure.DatabaseFacade database)
        {
            const string sql = @"
                DO $$ 
                DECLARE r RECORD;
                BEGIN
                    FOR r IN (SELECT tablename FROM pg_tables WHERE schemaname = 'public') LOOP
                        -- Включаем RLS
                        EXECUTE format('ALTER TABLE %I ENABLE ROW LEVEL SECURITY', r.tablename);
                
                        -- Создаем политику только если её нет
                        IF NOT EXISTS (
                            SELECT 1 FROM pg_policy 
                            WHERE polname = 'Admin bypass' 
                            AND polrelid = (quote_ident(r.tablename))::regclass
                        ) THEN
                            EXECUTE format('CREATE POLICY ""Admin bypass"" ON %I FOR ALL TO postgres USING (true)', r.tablename);
                        END IF;
                    END LOOP;
                END $$;";

            await database.ExecuteSqlRawAsync(sql);
        }

    }
}
