using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PrimeiraAtividade.Models.Request;

namespace PrimeiraAtividade.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly string _AlunoCaminhoArquivo;
        private int CodigoRA;

        public AlunoController()
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
            _AlunoCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Aluno.json");
        }

        #region Métodos arquivo
        private List<AlunoViewModel> LerAlunosArquivo()
        {
            if (!System.IO.File.Exists(_AlunoCaminhoArquivo))
            {
                return new List<AlunoViewModel>();
            }

            string json = System.IO.File.ReadAllText(_AlunoCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<AlunoViewModel>>(json);
        }


        private void EscreverAlunosArquivo(List<AlunoViewModel> alunos)
        {
            string json = JsonConvert.SerializeObject(alunos);
            System.IO.File.WriteAllText(_AlunoCaminhoArquivo, json);
        }
        #endregion

        #region Operações CRUD

        [HttpGet]
        public IActionResult Get()
        {
            List<AlunoViewModel> alunos = LerAlunosArquivo();
            return Ok(alunos);
        }

        [HttpGet("{RA}")]
        public IActionResult Get(string RA)
        {
            List<AlunoViewModel> alunos = LerAlunosArquivo();
            AlunoViewModel aluno = alunos.Find(a => a.RA == RA);
            if (aluno == null)
            {
                return NotFound();
            }

            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post([FromBody] AlunoViewModel newAluno)
        {
            if (newAluno == null)
            {
                return BadRequest();
            }

            List<AlunoViewModel> alunos = LerAlunosArquivo();

            if (alunos.Any(a => a.RA == newAluno.RA))

                return BadRequest("Já existe um aluno com esse RA.");

            AlunoViewModel novoAluno = new AlunoViewModel()
            {

                RA = newAluno.RA,
                Nome = newAluno.Nome,
                Email = newAluno.Email,
                CPF = newAluno.CPF,
                Ativo = newAluno.Ativo
            };

            alunos.Add(novoAluno);
            EscreverAlunosArquivo(alunos);

            return CreatedAtAction(nameof(Get), new { codigo = novoAluno.RA }, novoAluno);
        }

        [HttpPut("{RA}")]
        public IActionResult Put(string RA, [FromBody] AlunoViewModel aluno)
        {
            if (RA == null)

                return BadRequest();

            List<AlunoViewModel> alunos = LerAlunosArquivo();
            int index = alunos.FindIndex(a => a.RA == RA);
            if (index == -1)
                return NotFound();

            AlunoViewModel novoAluno = new AlunoViewModel()
            {
                RA = aluno.RA,
                Nome = aluno.Nome,
                Email = aluno.Email,
                CPF = aluno.CPF
            };

            alunos[index] = novoAluno;
            EscreverAlunosArquivo(alunos);

            return NoContent();
        }

        [HttpDelete("{RA}")]
        public IActionResult Delete(string RA)
        {
            List<AlunoViewModel> alunos = LerAlunosArquivo();
            AlunoViewModel aluno = alunos.Find(a => a.RA == RA);
            if (aluno == null)
                return NotFound();

            alunos.Remove(aluno);
            EscreverAlunosArquivo(alunos);

            return NoContent();
        }
        #endregion
    }
}