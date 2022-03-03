using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notlarim102.Entity.Messages
{
    public enum ErrorMessageCode
    {
        UsernameAllreadyExist = 101,
        EmailAllreadyExist=102,
        UserIsNotActive=151,
        UsernameOrPassWrong=152,
        CheckYourEmail=153,
        UserAllreadyActive=154,
        ActivateIdDoesNotExist=155,
        UserNotFound=156,
        ProfileCouldNotUpdate=157,
        UserCouldNotRemove=158,
        UserCouldNotFind=159,
        UserCouldNotInserted=160,
        UserCouldNotUpdated=161
    }
}
