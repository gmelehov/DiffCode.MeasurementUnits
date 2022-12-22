using System.Numerics;



namespace DiffCode.MeasurementUnits.Interfaces;

/// <summary>
/// <para>Интерфейс значения с единицей измерения.</para>
/// </summary>
/// <typeparam name="T">Тип значения.</typeparam>
/// <typeparam name="TUnits">Тип единицы измерения.</typeparam>
/// <typeparam name="TEnum">Тип перечисления единицы измерения.</typeparam>
public interface IMeasurement<out T, out TUnits, out TEnum> where T : INumberBase<T> where TUnits : IUnits<TUnits, TEnum> where TEnum : struct, Enum
{


  /// <summary>
  /// <para>Значение.</para>
  /// </summary>
  T Value { get; }

  /// <summary>
  /// <para>Единица измерения.</para>
  /// </summary>
  TUnits Measure { get; }

}