-- Добавление ролей
INSERT INTO table_role (role_name) VALUES ('admin');
INSERT INTO table_role (role_name) VALUES ('user');

-- Добавление аккаунтов
INSERT INTO table_account (login, password, role_id) VALUES ('admin', '123', 1);
INSERT INTO table_account (login, password, role_id) VALUES ('user', '123', 2);

-- Добавление пользователей
INSERT INTO table_user (first_name, last_name, email, photo) VALUES ('anonim', 'anonimus', 'anonim@admin.ru', 'url');
INSERT INTO table_user (first_name, last_name, email, photo) VALUES ('user', 'anonimus', 'user@admin.ru', 'url');