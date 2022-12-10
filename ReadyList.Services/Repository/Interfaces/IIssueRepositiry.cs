using ReadyList.Database.Models;

namespace ReadyList.Database.Repository.Interfaces;
public interface IIssueRepositiry
{
    public IEnumerable<Issue> GetAllIssues();

    public Issue GetIssueById(Guid issueId);

    public Issue CrateIssue(Issue issue);

    public void EditIssue(Issue issue);

    public void DeleteIssue(Guid issueId);
}
