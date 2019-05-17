# Attributor
## Desafio Attributtor - Hello World!

#### Objetivo:
Implementar um método que retorna "Hello World!" utilizando ASP.NET MVC em C# com Razor, subir o código para o git e fazer o deploy do projeto para a AWS

#### Programas Utilizados:
Visual Studio 2019; 
AWS Toolkit dor Visual Studio

#### Tuotriais que serviram como base:
ASP.NET MVC:
https://www.tutorialspoint.com/asp.net_mvc/asp.net_mvc_razor.htm
https://docs.microsoft.com/pt-br/aspnet/mvc/overview/getting-started/introduction/getting-started

AWS:
https://www.c-sharpcorner.com/article/deploying-a-web-application-to-aws/
https://docs.aws.amazon.com/pt_br/elasticbeanstalk/latest/dg/create_deploy_NET.quickstart.html

#### Arquivos criados/alterados para o projeto:
  *HomeController.cs*: criado a partir do comando "Acidionar->Controlador" na pasta "Controllers".
  
  *Index.cshtml*: criado a partir do arquivo "HomeController.cs", clicando com o botão direiro em "Index" e, em seguida, Adicionando uma Exibição. Este arquivo foi alterado para que a mensagem "Hello World!" aparecesse na página e html foi usado para melhorar a apresentação do texto.
                  Diretório: Views->Home->Index.cshtml
  
  *_Layout.cshtml*: uso de html para modificação da aparência da página.
                    Diretório: Views->Shared->Layout.cshtml
  
  
  
**Nota:** Para o retorno "Hello World" na página, pode-se proceder de duas maneiras:
  1- (Utliziada neste projeto):
    No arquivo "HomeContorller.cs", deixar o método ActionResult:
      
      public ActionResult Index()
        {
            return View();
        }
      ...
   
   E no arquivo "Index.cshtml":
      
      @{
           ViewBag.Title = "Hello Wordl!";
      } 
      <div style="border-radius:10px; background-color:#1B3465; margin-block-start: 50px; height=150px;" class="jumbotron">
      <h2 style="margin-left:40%; color:aqua; margin-inline-start: 38%;">@ViewBag.Title</h2>
      </div>
      ...

   2- No arquivo "HomeContorller.cs", deixar o método ActionResult:
      
      public ActionResult Index()
        {
            ViewBag.Message = "Hello World!";
            return View();
        }
      ...
   
   E no arquivo "Index.cshtml", colocar direto a parte de html:
      
      <div style="border-radius:10px; background-color:#1B3465; margin-block-start: 50px; height=150px;" class="jumbotron">
      <h2 style="margin-left:40%; color:aqua; margin-inline-start: 38%;">@ViewBag.Message</h2>
      </div>
      ...
      
   Nesse caso, também deve-se alterar a linha 6 do arquivo "_Layout.cshmtl"
   
    De: <title>@ViewBag.Title - Attributor</title>
    Para: <title>@ViewBag.Message - Attributor</title>
   
   
     
