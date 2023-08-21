using System.Runtime.Intrinsics.X86;
using static System.Net.WebRequestMethods;

namespace PrimeiraAtividade.Exercicios_do_1_ao_5
{
    //Ok() - Status 200 OK:
    //O método Ok() é usado para indicar que a requisição foi bem-sucedida.
    //Ele é usado quando a ação foi processada com sucesso e o servidor retornará um corpo de resposta contendo os dados relevantes para a solicitação.

    //BadRequest() - Status 400 Bad Request:
    //O método BadRequest() é usado para indicar que a requisição não pôde ser processada devido a dados inválidos ou inadequados fornecidos pelo cliente.
    //É um status geralmente usado quando a entrada do cliente não atende aos critérios esperados.

    //NotFound() - Status 404 Not Found:
    //O método NotFound() é usado para indicar que o recurso solicitado não foi encontrado no servidor.
    //Isso pode ocorrer quando o URL da requisição não corresponde a nenhum recurso conhecido.

    //InternalServerError() - Status 500 Internal Server Error:
    //O método InternalServerError() é usado para indicar que ocorreu um erro interno no servidor que impediu o processamento da requisição.
    //Esse status é geralmente usado quando um erro não tratado ocorre no servidor.

    //Unauthorized() - Status 401 Unauthorized:
    //O método Unauthorized() é usado para indicar que a requisição não foi autorizada.
    //Geralmente é usado quando o cliente não forneceu credenciais válidas ou não tem permissão para acessar o recurso.

    //Forbid() - Status 403 Forbidden:
    //O método Forbid() é usado para indicar que o acesso ao recurso é proibido, mesmo que o cliente tenha fornecido credenciais.
    //Isso é usado quando um cliente autenticado não tem permissão para acessar um determinado recurso.

    //NoContent() - Status 204 No Content:
    //O método NoContent() é usado para indicar que a requisição foi bem-sucedida, mas não há conteúdo para retornar no corpo da resposta.
    //Isso é útil quando a ação foi executada com sucesso, mas não há dados adicionais para retornar.

    //Esses métodos auxiliares são projetados para ajudar a construir respostas HTTP consistentes e padronizadas a partir das ações do controlador.
}
