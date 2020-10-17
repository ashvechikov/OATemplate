using System.Collections.Generic;
using Data.Group;

namespace Service.Interfaces
{
    public interface IGroupService
    {
        IEnumerable<Group> GetGroups();
        Group GetGroup(string id);
        void InsertGroup(Group user);
        void UpdateGroup(Group user);
        void DeleteGroup(string id);
    }
}