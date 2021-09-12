CREATE TABLE tb_Endereco (
endereco_Id INTEGER,
endereco_cliente_Id INTEGER,
endereco_Cidade VARCHAR(255),
endereco_UF VARCHAR(2),
endereco_Pais VARCHAR(255),
endereco_Rua VARCHAR(255),
endereco_Numero VARCHAR(10),
CONSTRAINT pk_tb_enderco_endereco_id PRIMARY KEY (endereco_id),
CONSTRAINT fk_tb_endereco_endereco_endereco_cliente_id FOREIGN KEY (endereco_cliente_Id) REFERENCES tb_Cliente(cliente_Id)
);

select * from tb_Endereco;


CREATE TABLE tb_Cliente (
cliente_Id INTEGER,
cliente_Nome VARCHAR(255),
cliente_Email VARCHAR(255),
CONSTRAINT pk_tb_cliente_cliente_id PRIMARY KEY(cliente_Id)
);

SELECT * FROM tb_Cliente;

CREATE TABLE tb_AnimaisPerdidos (
animaisPerdidos_Id INTEGER,
animaisPerdidos_Cliente_Id INTEGER,
CONSTRAINT pk_tb_animaisPerdidos_animaisperdidos_id PRIMARY KEY(animaisPerdidos_Id),
CONSTRAINT fk_tb_animaisPerdidos_animaisperdidos_cliente_id FOREIGN KEY (animaisPerdidos_Cliente_Id) REFERENCES tb_Cliente(cliente_Id)
);


SELECT * FROM tb_AnimaisPerdidos;

CREATE TABLE tb_AnimaisEncontrados (
animaisEncontrados_Id INTEGER,
animaisEncontrados_Cliente_Id INTEGER,
CONSTRAINT pk_tb_animaisEncontrados_animaisencontrados_id PRIMARY KEY(animaisEncontrados_Id),
CONSTRAINT fk_tb_animaisEncontrados_animaisencontrados_cliente_id FOREIGN KEY (animaisEncontrados_Cliente_Id) REFERENCES tb_Cliente(cliente_Id)
);

SELECT * FROM tb_AnimaisEncontrados;