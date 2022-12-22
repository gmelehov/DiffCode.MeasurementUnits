namespace DiffCode.MeasurementUnits.Interfaces;


/// <summary>
/// <para>Интерфейс единицы измерения.</para>
/// </summary>
/// <typeparam name="TUnits">Тип единицы измерения.</typeparam>
/// <typeparam name="TEnum">Тип перечисления единицы измерения.</typeparam>
public interface IUnits<out TUnits, out TEnum> where TEnum : struct, Enum
{


  /// <summary>
  /// <para>Перечисление единицы измерения.</para>
  /// </summary>
  TEnum Units { get; }

}
