using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserOperationClaimManager : IUserOperationClaimService
    {
        IUserOperationClaimDal _userOperationClaim;
        public UserOperationClaimManager(IUserOperationClaimDal userOperationClaim)
        {
            _userOperationClaim = userOperationClaim;
        }

        [SecuredOperation("admin")]
        public IResult Add(UserOperationClaim userOperationClaim)
        {
            _userOperationClaim.Add(userOperationClaim);

            return new SuccessResult(Messages.UserOperationClaimAdd);

        }
    }
}
