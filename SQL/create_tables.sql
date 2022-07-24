CREATE TABLE table_role (
    role_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    role_name TEXT NOT NULL
);
CREATE TABLE table_account (
    account_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    login TEXT NOT NULL,
    password TEXT NOT NULL,
    role_id INTEGER NOT NULL,
    is_active INTEGER NOT NULL DEFAULT 1,
    FOREIGN KEY (role_id) 
        REFERENCES table_role (role_id)
            ON UPDATE NO ACTION
            ON DELETE NO ACTION
);
CREATE TABLE table_user (
    user_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    first_name TEXT NOT NULL,
    last_name TEXT NOT NULL,
    email TEXT NOT NULL,
    photo TEXT NOT NULL,
    FOREIGN KEY (user_id) 
        REFERENCES table_account (account_id)
            ON UPDATE NO ACTION
            ON DELETE NO ACTION
);
