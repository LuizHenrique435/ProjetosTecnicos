<?php

	header("Access-Control-Allow-Origin: *");
	header("Access-Control-Allow-Headers: Content-Type");
	date_default_timezone_set('America/Sao_Paulo');	
	
	include('conexao.php'); 
	
	$data = new DateTime(); 
	
    $sdata = $data->format('Y-m-d');

    $sexo = $_GET['sexo'];
    $nome = $_GET['nome'];
    $idade = $_GET['idade'];
    $temp = $_GET['temp'];
    $orig = $_GET['orig'];	
    	
	try 
	{ 
		// Grava banco de dados
		
		$conecta = new PDO("mysql:host=$servidor;dbname=$banco", $usuario , $senha, array(PDO::MYSQL_ATTR_INIT_COMMAND => "SET NAMES utf8"));		
		
        $query = "INSERT INTO tb01_corona (tb01_nome, tb01_idade, tb01_sexo, tb01_nacionalidade, tb01_data, tb01_temp) VALUES ('$nome', '$idade', '$sexo', '$orig','$sdata','$temp')";
				  
		$grava = $conecta->prepare($query);
		$grava->execute(array()); 
				
	} 
	catch(PDOException $e) 
	{ 
		echo('Deu erro: ' . $e->getMessage()); 
	}
 
?>