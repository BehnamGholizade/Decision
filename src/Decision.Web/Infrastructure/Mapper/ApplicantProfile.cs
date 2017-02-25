﻿namespace Decision.Web.Infrastructure.Mapper
{
    public class ApplicantProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<AddApplicantViewModel, Applicant>()
                                .ForMember(d => d.BirthCertificateNumber, m => m.MapFrom(a => a.BirthCertificateNumber.GetPersianNumber()))
                 .ForMember(d => d.NationalCode, m => m.MapFrom(a => a.NationalCode))
                .IgnoreAllNonExisting();

            CreateMap<EditApplicantViewModel, Applicant>()
                .ForMember(d => d.BirthCertificateNumber,
                    m => m.MapFrom(a => a.BirthCertificateNumber.GetPersianNumber()))
                .ForMember(d => d.NationalCode, m => m.MapFrom(a => a.NationalCode))
                .IgnoreAllNonExisting();

            CreateMap<Applicant, EditApplicantViewModel>().IgnoreAllNonExisting();

            CreateMap<Applicant, ApplicantDetailsViewModel>()
                .ForMember(a => a.TrainingCourseDetails, m => m.Ignore())
              
              .ForMember(a => a.CreatorUserName, m => m.MapFrom(s => s.CreatedBy.UserName))
              .ForMember(a => a.LastModifierUserName, m => m.MapFrom(s => s.ModifiedBy.UserName))
              .ForMember(d => d.FullName, m => m.MapFrom(s => s.FirstName + " " + s.LastName)).IgnoreAllNonExisting();

            CreateMap<Applicant, ApplicantViewModel>()
                
                .ForMember(a => a.CreatorUserName, m => m.MapFrom(s => s.CreatedBy.UserName))
                .ForMember(a => a.LastModifierUserName, m => m.MapFrom(s => s.ModifiedBy.UserName))
                .ForMember(d => d.FullName, m => m.MapFrom(s => s.FirstName + " " + s.LastName)).IgnoreAllNonExisting();

            CreateMap<Applicant, NewAddedApplicantViewModel>()
              .ForMember(d => d.FullName, m => m.MapFrom(s => s.FirstName + " " + s.LastName)).IgnoreAllNonExisting();

            CreateMap<Applicant, ApplicantWithTopScoreViewModel>()
            .ForMember(d => d.FullName, m => m.MapFrom(s => s.FirstName + " " + s.LastName)).IgnoreAllNonExisting();


        }

        public override string ProfileName => GetType().Name;
    }
}
