-- 1. Crear la base de datos y usarla
CREATE DATABASE IF NOT EXISTS proyectotere_db;
USE proyectotere_db;

-- 2. Crear la tabla de Usuarios
CREATE TABLE IF NOT EXISTS usuarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    rol VARCHAR(20) NOT NULL -- Valores esperados: 'Admin', 'Revisor', 'Vendedor'
);

-- 3. Crear la tabla de Productos
CREATE TABLE IF NOT EXISTS Productos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    tipo VARCHAR(50) NOT NULL,             -- Ej: 'Cartas TCG', 'Figuras', 'Comics/Manga'
    franquicia VARCHAR(100) NOT NULL,
    numero_serie VARCHAR(100) NOT NULL,
    precio_coste DECIMAL(10, 2) NOT NULL,
    valor_mercado DECIMAL(10, 2) NOT NULL,
    descripcion TEXT,
    stock INT NOT NULL DEFAULT 0,
    estado_activo TINYINT(1) NOT NULL DEFAULT 1, -- 1 = Activo, 0 = Dado de baja
    fecha_ultima_modificacion DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    
    -- Atributos específicos para herencia (pueden quedar en NULL dependiendo del tipo de producto)
    rareza VARCHAR(50),          -- Solo para Cartas
    expansion VARCHAR(100),      -- Solo para Cartas
    estado_grading VARCHAR(50),  -- Solo para Cartas (ej. PSA 10, Near Mint)
    escala VARCHAR(50),          -- Solo para Figuras
    fabricante VARCHAR(100),     -- Solo para Figuras
    numero_tomo INT              -- Solo para Comics/Manga
);

-- 4. Crear la tabla del Histórico de Ventas
CREATE TABLE IF NOT EXISTS VentasHistorico (
    id INT AUTO_INCREMENT PRIMARY KEY,
    id_articulo INT NOT NULL,
    id_vendedor INT NOT NULL,
    estado_entrega VARCHAR(255),
    fecha DATETIME DEFAULT CURRENT_TIMESTAMP,
    
    -- Llaves foráneas para mantener la integridad de los datos
    FOREIGN KEY (id_articulo) REFERENCES Productos(id) ON DELETE CASCADE,
    FOREIGN KEY (id_vendedor) REFERENCES usuarios(id) ON DELETE CASCADE
);

-- ==========================================================
-- DATOS DE PRUEBA INICIALES
-- ==========================================================

-- Insertar un usuario Administrador por defecto para poder iniciar sesión
INSERT INTO usuarios (username, password, rol) 
VALUES ('admin', '1234', 'Admin');

-- (Opcional) Insertar un producto de prueba
INSERT INTO Productos (tipo, franquicia, numero_serie, precio_coste, valor_mercado, descripcion, stock, estado_activo, rareza, expansion, estado_grading) 
VALUES ('Carta TCG', 'Pokémon', 'PKM-001-CHZ', 15.00, 150.00, 'Charizard Base Set', 5, 1, 'Holo Rare', 'Base Set', 'PSA 8');