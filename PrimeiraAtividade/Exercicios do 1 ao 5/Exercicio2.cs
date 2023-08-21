using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System;
using Microsoft.Extensions.Hosting;
using static System.Net.WebRequestMethods;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Security.Claims;

namespace PrimeiraAtividade.Exercicios_do_1_ao_5
{
//a) Papel do Controller e Model e herança de ControllerBase:

//Controller: O Controller é uma parte fundamental da arquitetura MVC(Model-View-Controller) em desenvolvimento de software.
//Ele atua como um intermediário entre as requisições do usuário e a lógica de negócios da aplicação.
//O Controller recebe as requisições, toma decisões baseadas nessas requisições e interage com os Models para obter ou modificar os dados necessários.
//Além disso, o Controller é responsável por determinar qual View será apresentada para o usuário após processar os dados.

//Model: O Model é a representação dos dados e regras de negócio da aplicação.
//Ele lida com a manipulação e persistência dos dados, garantindo que a aplicação possa acessar, armazenar e modificar informações de maneira consistente.
//O Model encapsula a lógica que permite que os dados sejam recuperados, atualizados e manipulados de acordo com as regras definidas.
//Ao criar um Controller, muitas vezes é feita a herança de uma classe base como "ControllerBase" por motivos de reutilização de código.

//Essa herança permite aproveitar funcionalidades e métodos comuns fornecidos pela classe base, evitando a necessidade de reescrever código repetitivo em todos os Controllers.
//Isso ajuda a manter um padrão consistente e a simplificar o desenvolvimento.

//b) Execução de Rota GET e POST:

//A diferença entre as rotas GET e POST está relacionada ao tipo de requisição HTTP que cada uma representa:

//GET: É utilizado para solicitar recursos do servidor.
//As requisições GET são consideradas "seguras" e "idempotentes", o que significa que uma mesma requisição GET repetida várias vezes não deve causar efeitos colaterais e deve retornar o mesmo resultado.

//POST: É utilizado para enviar dados ao servidor para que sejam processados.
//As requisições POST podem causar efeitos colaterais, como criar, atualizar ou deletar informações no servidor.

//A razão pela qual você pode executar uma rota GET diretamente no navegador, mas não uma rota POST, está relacionada à maneira como os navegadores interagem com essas requisições.
//Os navegadores são projetados para facilitar a visualização de informações (requisições GET) e, por razões de segurança, eles não permitem que você envie diretamente requisições POST sem algum tipo de interação ou envio de formulário.

//c) Papel do Swagger:

//O Swagger é uma ferramenta amplamente usada para documentar APIs(Interfaces de Programação de Aplicativos).
//Ele permite descrever, de forma padronizada, as funcionalidades, endpoints, parâmetros, tipos de dados e outras informações relevantes de uma API.
//Isso facilita a compreensão e o uso da API por parte dos desenvolvedores, pois fornece uma documentação clara e interativa.
//Ao utilizar o Swagger, os desenvolvedores podem explorar a documentação da API, testar endpoints diretamente na interface do Swagger e gerar automaticamente bibliotecas de clientes para várias linguagens de programação.
//Isso ajuda a reduzir erros de implementação, acelera o desenvolvimento de integrações com a API e melhora a colaboração entre as equipes de desenvolvimento que trabalham em diferentes partes do projeto.
//Em resumo, o Swagger desempenha um papel crucial na facilitação da compreensão, uso e integração de APIs, tornando o processo de desenvolvimento mais eficiente e eficaz.
}
