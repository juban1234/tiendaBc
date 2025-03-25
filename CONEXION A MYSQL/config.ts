import mysql from 'mysql2/promise';

const db = mysql.createPool({
    host: '192.168.1.100',
    user: 'juanGrajales',
    password: '',
    database: 'tiendadb',
    connectionLimit: 10,
    queueLimit: 0
});

export default db;
