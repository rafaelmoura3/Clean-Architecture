using CleanArchMvc.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace CleanArchMvc.Domain.Tests
{
    public class CategoryUninitTest1
    {
        [Fact(DisplayName = "Create Category With Valid State")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Category Name");
            action.Should()
                .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Category With Not Valid State")]
        public void CreateCategory_NegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Category(-1, "Category Name");
            action.Should().Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                    .WithMessage("Invalid Id value");
        }

        [Fact(DisplayName = "Create Category Short Name Value")]
        public void CreateCategory_ShortNameValue_DomainExceptionInvalidId()
        {
            Action action = () => new Category(1, "Ca");
            action.Should().Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                    .WithMessage("Invalid name, too short, minimum 3 characters");
        }

        [Fact(DisplayName = "Create Category With Null Name Value")]
        public void CreateCategory_WithMissingNameValue_DomainExceptionInvalidId()
        {
            Action action = () => new Category(1, "");
            action.Should().Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                    .WithMessage("Invalid name.Name is required");
        }

        [Fact(DisplayName = "Create Category With Null Name Value")]
        public void CreateCategory_WithNullNameValue_DomainExceptionInvalidId()
        {
            Action action = () => new Category(1, null);
            action.Should().Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

    }
}
