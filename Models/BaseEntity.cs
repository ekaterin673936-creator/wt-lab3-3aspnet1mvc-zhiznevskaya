using WtLab3Mvc.Interfaces;

namespace WtLab3Mvc.Models;

public abstract class BaseEntity : IStorable
{
    public int Id { get; protected set; }
    public DateTime CreatedAt { get; protected set; } = DateTime.Now;
    public abstract void PrintInfo();
}