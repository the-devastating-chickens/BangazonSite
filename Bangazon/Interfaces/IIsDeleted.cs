// Author: Chris Morgan

// The IIsDeleted interface holds the purpose of labeling all the resources that we want to soft delete. It contains one property, Active (boolean). This is used to see if the resource has been 'deleted' by the user

namespace Bangazon.Interfaces
{
    public interface IIsDeleted
    {
        bool Active { get; set; }
    }
}
