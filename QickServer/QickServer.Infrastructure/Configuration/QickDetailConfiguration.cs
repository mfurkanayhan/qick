﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QickServer.Domain.QickDetails;
using QickServer.Domain.Qicks;

namespace QickServer.Infrastructure.Configuration;
internal sealed class QickDetailConfiguration : IEntityTypeConfiguration<QickDetail>
{
    public void Configure(EntityTypeBuilder<QickDetail> builder)
    {
        builder.Property(p => p.Id).HasConversion(id => id.Value, value => new Id(value));

        builder.Property(p => p.QickId).HasConversion(id => id.Value, value => new Id(value));

        builder.Property(p => p.Title).HasConversion(title => title.Value, value => Title.Create(value)).HasColumnType("varchar(200)");

        builder.Property(p => p.AnswerA).HasConversion(answer => answer.Value, value => new Answer(value)).HasColumnType("varchar(100)");

        builder.Property(p => p.AnswerB).HasConversion(answer => answer.Value, value => new Answer(value)).HasColumnType("varchar(100)");

        builder.Property(p => p.AnswerC).HasConversion(answer => answer.Value, value => new Answer(value)).HasColumnType("varchar(100)");

        builder.Property(p => p.AnswerD).HasConversion(answer => answer.Value, value => new Answer(value)).HasColumnType("varchar(100)");

        builder.Property(p => p.CorrectAnswer).HasConversion(correctAnswer => correctAnswer.Value, value => CorrectAnswer.FromValue(value));

        builder.Property(p => p.TimeOut).HasConversion(timeOut => timeOut.Value, value => new TimeOut(value));
    }
}
