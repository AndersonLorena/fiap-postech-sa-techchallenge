﻿using AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Controllers.Base;
using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries.Dtos;
using AutoMapper;
using MediatR;

namespace AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Controllers
{
    public sealed class IngredientController : CrudBaseController<
        CreateIngredientCommand,
        IngredientDto,
        UpdateIngredientCommand,
        DeleteIngredientCommand,
        IngredientEntity>
    {
        public IngredientController(
            ISender mediator,
            IQueryRepository<IngredientEntity> queryRepository,
            IMapper mapper)
            : base(
                  mediator,
                  queryRepository,
                  mapper)
        {
        }
    }
}