<?php

	header("Access-Control-Allow-Origin: *");
	header("Access-Control-Allow-Headers: Content-Type");
	date_default_timezone_set('America/Sao_Paulo');	
	
	include('conexao.php'); 

    $nomex = $_GET['nomecad'];
    $usuariox = $_GET['usuariocad'];
    $senhax = $_GET['senhacad'];	
    	
	try 
	{ 
		// Grava banco de dados
		
		$conecta = new PDO("mysql:host=$servidor;dbname=$banco", $usuario , $senha, array(PDO::MYSQL_ATTR_INIT_COMMAND => "SET NAMES utf8"));		
		
        $query = "INSERT INTO tb02_login (tb02_nome, tb02_usuario, tb02_senha) VALUES ('$nomex', '$usuariox', '$senhax')";
				  
		$grava = $conecta->prepare($query);
		$grava->execute(array()); 
				
	} 
	catch(PDOException $e) 
	{ 
		echo('Deu erro: ' . $e->getMessage()); 
	}
 
?>