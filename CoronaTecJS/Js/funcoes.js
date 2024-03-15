var nome;
var idade;
var sexo;
var temperatura;
var origem;
var entrevistados = 0;
var totalfebris = 0;
var febrisderisco = 0;
var grupoderisco = 0;
var feminino = 0;
var masculino = 0;

function validade() {

    nome = document.getElementById('txtNome').value;
    idade = document.getElementById('txtIdade').value;
    sexo = document.getElementById('txtSexo').value;
    temperatura = document.getElementById('txtTemp').value;
    origem = document.getElementById('txtOrigem').value;


    if (nome == '' ||
        idade == '' ||
        sexo == '---' ||
        temperatura == '' ||
        origem == '---') {
        alert("Preenche os campos ai baiano !");
    } else {
        alert("Pesquisa Concluida !")
        inclui();
        registra();
    }

}


function registra() {

    if (idade > 60) {

        grupoderisco++;

    }
    if (temperatura > 38) {
        totalfebris++;
    }
    if (idade > 60 && temperatura > 38) {
        febrisderisco++;
    }
    if (sexo == "1") {
        masculino++
    }
    if (sexo == "2") {
        feminino++
    }


    entrevistados++;
    console.log("--ESTATÍSTICAS--")
    console.log("ENTREVISTADOS: " + entrevistados)
    console.log("GRUPO DE RISCO: " + grupoderisco)
    console.log("TOTAL FEBRIS: " + totalfebris)
    console.log("FEBRISDERISCO: " + febrisderisco)
    console.log("MASCULINO: " + masculino)
    console.log("FEMININO: " + feminino)

}

function login()
{

    usuario = document.getElementById("usuario").value;
    senha = document.getElementById("senha").value;

    if(usuario == "" || senha == "")
    {
        alert("Preencha Todos Os Campos !!!");
        return;

    }
    var xmlhttp = new XMLHttpRequest();

		//Prepara link para acionar PHP
		
		var url = "http://localhost:8080/php/login.php/?usuario=" + usuario + "&senha=" + senha;
		
		xmlhttp.onreadystatechange = function () 
		{
			
			if (xmlhttp.readyState == 4 && xmlhttp.status == 200)
			{
				ConectaServidor(xmlhttp.responseText);
			}
		}
		
		xmlhttp.open("GET", url, true);
		xmlhttp.send();
			
		function ConectaServidor(response) {
			 
			var dados = JSON.parse(response); //faz a conversão do texto da WEB para JSON
			var i=0;
			var conteudo = "";
			var linhas;
			
			// O for() vai montar a linha (<TR>) da tabela
			for (i = 0; i < dados.length; i++) //dados.length retorna o tamanho do vetor.
			{
				if (dados[i].tb02_usuario == "vazio")
				{
					alert("Acesso Negado!");
                    alert("Faça seu Cadastro!")

				}
				else
				{
					alert("Usuario Encontrado com Sucesso !!!");
                    alert("Seja Bem Vindo " + usuario + " !!!");
                    localStorage.setItem("usuario", usuario);
                    window.location.href='index.html';
				}
			}	
        }
}


function Bemvindo()
{

    document.getElementById("bemvindo").innerHTML = localStorage.getItem("usuario");

}

function inclui(){
    
    var xmlhttp = new XMLHttpRequest();
    
    var nome = document.getElementById('txtNome').value;
    var idade = document.getElementById('txtIdade').value;
    
    if(document.getElementById('txtSexo').value == "1"){
        
        var sexo = "Masculino";
    }
    if(document.getElementById("txtSexo").value == "2")
        {
            var sexo = "Feminino";
        }
    var temp = document.getElementById('txtTemp').value;
    var orig = document.getElementById('txtOrigem').value;
    
    var url = "http://localhost:8080/php/inclui.php/?nome=" + nome + "&idade=" + idade + "&sexo=" + sexo + "&temp=" + temp + "&orig=" + orig;
    
    xmlhttp.open("GET", url, true);
    xmlhttp.send();
    
    
}

function cadastro(){

    if(nomecad == " " || usuariocad == " " || senhacad == " ")
    {
        alert("Preencha Todos Os Campos !!!");
        return;
    }
    else{

    alert('Cadastrado Com Sucesso!!!');
    

    var xmlhttp = new XMLHttpRequest();
    
    var nomecad = document.getElementById('nomecad').value;
    var usuariocad = document.getElementById('usuariocad').value;
    var senhacad = document.getElementById('senhacad').value;
    
    var url = "http://localhost:8080/php/cadastro.php/?nomecad=" + nomecad + "&usuariocad=" + usuariocad + "&senhacad=" + senhacad;
    console.log(url);
    
    xmlhttp.open("GET", url, true);
    xmlhttp.send();

    }
    
}

	function lista()
	{		
		
	    var xmlhttp = new XMLHttpRequest();

		//Prepara link para acionar PHP
		
		var url = "http://localhost:8080/php/listacorona.php";
		
		xmlhttp.onreadystatechange = function () 
		{
			
			if (xmlhttp.readyState == 4 && xmlhttp.status == 200)
			{
				ConectaServidor(xmlhttp.responseText);
			}
		}
		
		xmlhttp.open("GET", url, true);
		xmlhttp.send();
			
		function ConectaServidor(response) {
			 
			var dados = JSON.parse(response); //faz a conversão do texto da WEB para JSON
			var i=0;
			var conteudo = "";
			var linhas;
			
			// O for() vai montar a linha (<TR>) da tabela
			for (i = 0; i < dados.length; i++) //dados.length retorna o tamanho do vetor.
			{
				if (dados[i].tb01_nome == "vazio")
				{
					limpaID();
					alert("Consulta invalida");

				}
				else
				{
					conteudo += '<tbody id="lnome">'
					conteudo += '<tr>';
					conteudo += '<td>' + dados[i].tb01_nome + '</td>';	
					conteudo += '<td style="text-align: center">' + dados[i].tb01_idade + '</td>';
					conteudo += '<td style="text-align: center">' + dados[i].tb01_nacionalidade + '</td>';
					conteudo += '</tr>';
					conteudo += '</tbody>';
				}
			}	

			document.getElementById('lnome').innerHTML = conteudo;			
		}		
	}

function mudalista() {

    document.getElementById("Ntotalfebris").innerHTML = totalfebris + " (" + ((totalfebris / entrevistados) * 100).toFixed(2) + "%) ";
    document.getElementById("Nfebrisderisco").innerHTML = febrisderisco + " (" + ((totalfebris / entrevistados) * 100).toFixed(2) + "%) ";
    document.getElementById("Ngrupoderisco").innerHTML = grupoderisco + " (" + ((grupoderisco / entrevistados) * 100).toFixed(2) + "%) ";
    document.getElementById("Nfeminino").innerHTML = feminino;
    document.getElementById("Nmasculino").innerHTML = masculino;
    document.getElementById("Nestrevistados").innerHTML = entrevistados;

}


function ingles() {

    document.getElementById('titulo').innerHTML = "CORONAVIRUS<br> RESEARCH"
    document.getElementById('nome').innerHTML = "Name:"
    document.getElementById('idade').innerHTML = "Age:"
    document.getElementById('sexo').innerHTML = "Sex:"
    document.getElementById('temperatura').innerHTML = "Temperature:"
    document.getElementById('origem').innerHTML = "Origin:"
    document.getElementById('btngrava').innerHTML = "RECORD"
    document.getElementById('btnresumo').innerHTML = "ABSTRACT"
    document.getElementById('btnlista').innerHTML = "LIST"
    document.getElementById("entrevistados").innerHTML = "Interviewed : ";
    document.getElementById("totalfebris").innerHTML = "Total febrile : ";
    document.getElementById("febrisderisco").innerHTML = "Risk Fever : ";
    document.getElementById("grupoderisco").innerHTML = "Group of risk : ";
    document.getElementById("feminino").innerHTML = "Women : ";
    document.getElementById("masculino").innerHTML = "Male : ";
    document.getElementById("BotaoModal").innerHTML = "What is the Corona Vírus ?";
    document.getElementById("TModal").innerHTML = "What is the Corona Virus ?";
    document.getElementById("t1").innerHTML = "COVID-19 affects different people in different ways. Most infected people will have mild to moderate symptoms of the disease and will not need to be hospitalized.";
    document.getElementById("t2").innerHTML = "Most common symptoms: <br> - fever <br> - Dry cough <br> - Tiredness";
    document.getElementById("t3").innerHTML = "Less common symptoms: <br> - pain and discomfort <br> - sore throat <br> - diarrhea <br> - conjunctivitis <br> - headache <br> - loss of taste or smell <br> - rash on the skin or discoloration of the fingers or toes";
    document.getElementById("t4").innerHTML = "Prevention";
    document.getElementById("t5").innerHTML = "Protect yourself and the people around you by knowing the facts and taking appropriate precautions. Follow the advice of your local health authority.";
    document.getElementById("t6").innerHTML = "To prevent the spread of COVID-19, do the following: <br> - Wash your hands frequently.Use soap and water or gel alcohol. <br> - Keep a safe distance from people who are coughing or sneezing. <br> -Wear a mask when it is not possible to maintain physical distance. <br> - Don 't touch your eyes, nose or mouth. <br> - Cover your nose and mouth with a bent arm or a handkerchief when you cough or exhale. <br> - Stay homeif you feel unwell. <br> - Get medical attentionif you have a fever, cough and difficulty breathing. <br> - Call the health plan or agency in advance and ask for directions to the most appropriate unit.This protects you and prevents the spread of viruses and other infections. <br> Masks:<br> Whoever wears a mask can help prevent the virus from spreading to others.In isolation, masks are not a protection against COVID - 19, and their use must be combined with physical distance and hand cleaning.Follow the guidelines of your local health authority.";
    document.getElementById("t7").innerHTML = "Close";
    document.getElementById("t8").innerHTML = "Learn More...";
    document.getElementById("t9").innerHTML = "Welcome User " + localStorage.getItem("usuario");


}

function portugues() {

    document.getElementById('titulo').innerHTML = "PESQUISA DO <br> CORONAVIRUS"
    document.getElementById('nome').innerHTML = "Nome:"
    document.getElementById('idade').innerHTML = "Idade:"
    document.getElementById('sexo').innerHTML = "Sexo:"
    document.getElementById('temperatura').innerHTML = "Temperatura:"
    document.getElementById('origem').innerHTML = "Origem:"
    document.getElementById('btngrava').innerHTML = "GRAVA"
    document.getElementById('btnresumo').innerHTML = "RESUMO"
    document.getElementById('btnlista').innerHTML = "LISTA"

    document.getElementById("entrevistados").innerHTML = "Entrevistados : ";
    document.getElementById("totalfebris").innerHTML = "Total Febris : ";
    document.getElementById("febrisderisco").innerHTML = "Febris de Risco : ";
    document.getElementById("grupoderisco").innerHTML = "Grupo de Risco : ";
    document.getElementById("feminino").innerHTML = "Feminino : ";
    document.getElementById("masculino").innerHTML = "Masculino : ";
    document.getElementById("BotaoModal").innerHTML = "O que é o Corona Vírus ?";
    document.getElementById("TModal").innerHTML = "O que é o Corona Vírus ?";
    document.getElementById("t1").innerHTML = "A COVID-19 afeta diferentes pessoas de diferentes maneiras. A maioria das pessoas infectadas apresentará sintomas leves a moderados da doença e não precisarão ser hospitalizadas.";
    document.getElementById("t2").innerHTML = "Sintomas mais comuns :<br> - febre <br> - Tosse Seca <br> - Cansaço";
    document.getElementById("t3").innerHTML = "Sintomas menos comuns :<br> - dores e desconfortos <br> - dor de garganta <br> - Diarreia <br> - conjuntivite <br> - dor de cabeça <br> - perda de paladar ou olfato <br> - erupção cutânea na pele ou descoloração dos dedos das mãos ou dos pés";
    document.getElementById("t4").innerHTML = "Prevenção";
    document.getElementById("t5").innerHTML = "Proteja a si mesmo e as pessoas ao seu redor conhecendo os fatos e tomando as precauções apropriadas. Siga os conselhos da autoridade local de saúde.";
    document.getElementById("t6").innerHTML = "Para evitar a propagação da COVID-19, faça o seguinte: <br> -Lave suas mãos com frequência.Use sabão e água ou álcool em gel. <br> -Mantenha uma distância segura de pessoas que estiverem tossindo ou espirrando. <br> - Use máscara quando não for possível manter o distanciamento físico. <br> - Não toque nos olhos, no nariz ou na boca. <br> - Cubra seu nariz e boca com o braço dobrado ou um lenço ao tossir ou expirar. <br> - Fique em casa se você se sentir indisposto. <br> - Procure atendimento médico se tiver febre, tosse e dificuldade para respirar. <br> - Ligue com antecedência para o plano ou órgão de saúde e peça direcionamento à unidade mais adequada.Isso protege você e evita a propagação de vírus e outras infecções. <br> Máscaras: <br> Quem usa máscara pode ajudar a prevenir a propagação do vírus para outras pessoas.Isoladamente, as máscaras não são uma proteção contra a COVID - 19, e o uso delas deve ser combinado com o distanciamento físico e a limpeza das mãos.Siga as orientações da autoridade local de saúde.";
    document.getElementById("t7").innerHTML = "Fechar";
    document.getElementById("t8").innerHTML = "Saiba Mais...";
    document.getElementById("t9").innerHTML = "Bem Vindo Usuario " + localStorage.getItem("usuario");



}
