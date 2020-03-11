using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{

    public class PacotesRepository : IPacotesRepository
    {
        SenaturContext ctx = new SenaturContext();
        public void Atualizar(Pacotes pacotesAtualizado, int id)
        {
            Pacotes pacotesBuscado = ctx.Pacotes.Find(id);

            if (pacotesAtualizado.NomePacotes != null)
            {
                pacotesBuscado.NomePacotes = pacotesAtualizado.NomePacotes;
            }

            if (pacotesAtualizado.Descricao != null)
            {
                pacotesBuscado.Descricao = pacotesAtualizado.Descricao;
            }

            if (pacotesAtualizado.DataIda != null)
            {
                pacotesBuscado.DataIda = pacotesAtualizado.DataIda;
            }

            if (pacotesAtualizado.DataVolta != null)
            {
                pacotesBuscado.DataVolta = pacotesAtualizado.DataIda;
            }

            if (pacotesAtualizado.Valor != null)
            {
                pacotesBuscado.Valor = pacotesAtualizado.Valor;
            }

            if (pacotesAtualizado.Ativo != null)
            {
                pacotesBuscado.Ativo = pacotesAtualizado.Ativo;
            }

            if (pacotesAtualizado.NomeCidade != null)
            {
                pacotesBuscado.NomeCidade = pacotesAtualizado.NomeCidade;
            }

            ctx.Update(pacotesBuscado);
            ctx.SaveChanges();
        }

        public Pacotes BuscarPorId(int id)
        {
            return ctx.Pacotes.FirstOrDefault(e => e.IdPacotes == id);
        }

        public List<Pacotes> Listar()
        {
            return ctx.Pacotes.ToList();
        }

        public void Cadastrar(Pacotes novoPacotes)
        {
            ctx.Pacotes.Add(novoPacotes);
            ctx.SaveChanges();
        }

    }
}
