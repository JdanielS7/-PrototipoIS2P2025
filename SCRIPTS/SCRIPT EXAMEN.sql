use colchoneria;
INSERT INTO `tbl_modulos` (`Pk_id_modulos`, `nombre_modulo`, `descripcion_modulo`, `estado_modulo`) VALUES
(20000, 'EVALUACION', 'Evaluación', 1);

INSERT INTO `tbl_aplicaciones` (`Pk_id_aplicacion`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES
(20001, 'Mant. VENDEDORES', 'PARA EXAMEN', 1)
;


drop table vendedores;

CREATE TABLE vendedores
(
	codigo_vendedor VARCHAR(5) PRIMARY KEY,
    nombre_vendedor VARCHAR(60),
    direccion_vendedor VARCHAR(60),
    telefono_vendedor VARCHAR(50),
    nit_vendedor VARCHAR(20),
    `Estado` TINYINT(4) DEFAULT NULL
) ENGINE=INNODB DEFAULT CHARSET=latin1;