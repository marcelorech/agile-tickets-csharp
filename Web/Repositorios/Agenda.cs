﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AgileTickets.Web.Models;

namespace AgileTickets.Web.Repositorios
{
    public interface Agenda
    {
        // esta interface é implementada na camada DAO
        IList<Espetaculo> Espetaculos();
        Espetaculo Espetaculo(int id);
        void Atualiza(Sessao sessao);
        void Cadastra(Espetaculo espetaculo);
        Sessao Sessao(int sessaoId);
        IList<Sessao> ProximasSessoes(int maximo);
        void Agende(List<Sessao> sessoes);
    }
}