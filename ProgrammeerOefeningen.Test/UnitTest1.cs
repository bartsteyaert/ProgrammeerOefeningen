using System;
using Xunit;
using Programmeeroefeningen;
using FluentAssertions;

namespace ProgrammeerOefeningen.Test
{
    public class Test
    {
        [Fact]
        public void Oefening1()
        {
            var kat = Program.Oefening1();
            kat.Naam.Should().Be("Josefien");
            kat.ZegNaam().ToLowerInvariant().Should().Be("Hallo, ik ben Josefien.".ToLowerInvariant());
        }
    }
}