using System.Collections.Generic;
using Repository;
using Service.Interfaces;
using Data.Group;

namespace Service.Services
{
    public class GroupService : IGroupService
    {
        private IRepository<Group> _groupRepository;

        public GroupService(IRepository<Group> groupRepository)
        {
            this._groupRepository = groupRepository;
        }

        public IEnumerable<Group> GetGroups()
        {
            return _groupRepository.GetAll();
        }

        public Group GetGroup(string id)
        {
            return _groupRepository.Get(id);
        }

        public void InsertGroup(Group group)
        {
            _groupRepository.Insert(group);
        }
        public void UpdateGroup(Group group)
        {
            _groupRepository.Update(group);
        }

        public void DeleteGroup(string id)
        {
            Group group = GetGroup(id);
            _groupRepository.Remove(group);
            _groupRepository.SaveChanges();
        }
    }
}