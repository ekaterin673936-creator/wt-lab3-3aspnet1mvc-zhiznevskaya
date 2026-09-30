namespace WtLab3Mvc.Interfaces;

public interface IStorable
{
    int Id { get; }
    DateTime CreatedAt { get; }
    void PrintInfo();
}