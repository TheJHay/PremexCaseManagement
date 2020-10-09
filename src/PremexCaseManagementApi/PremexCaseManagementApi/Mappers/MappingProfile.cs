using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using PremexCaseManagementApi.Models.Dtos.BigBoys;
using PremexCaseManagementApi.Models.Entities;

namespace PremexCaseManagementApi.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Message, PremexCase>()
                .ForMember(
                    dest => 
                        dest.AccidentDate, 
                    opt => 
                        opt.MapFrom(
                            src => 
                                src.MessageBody.Instruction.Accident.AccidentDate))

                .ForMember(
                    dest =>
                        dest.AccidentTime,
                    opt =>
                        opt.MapFrom(
                            src =>
                                src.MessageBody.Instruction.Accident.AccidentTime))

                .ForMember(
                    dest =>
                        dest.Injuries,
                    opt =>
                        opt.MapFrom(
                            src =>
                                string.Join(",", src.MessageBody.Instruction.Accident.InjuryList)))
                
                .ForMember(
                    dest =>
                        dest.ClientAddress1,
                    opt =>
                        opt.MapFrom(
                            src =>
                                string.Join(",", src.MessageBody.Instruction.Accident.InjuryList)))
                .ReverseMap();
        }
    }
}
