using CourseWork_2.Domain.Models;

namespace CourseWork_2.Domain.Service;

public interface ICompanyService
{
    bool RewardEmployee(Company company, Employee employee, Reward reward);
    bool PunishEmployee(Company company, Human human, Punishment punishment);
}