using DiffCode.MeasurementUnits.Interfaces;

using System.Numerics;



namespace DiffCode.MeasurementUnits.Base;


/// <summary>
/// <para>Базовая модель значения с единицей измерения.</para>
/// </summary>
/// <typeparam name="T">Тип значения.</typeparam>
/// <typeparam name="U">Тип единицы измерения.</typeparam>
/// <typeparam name="E">Тип перечисления единицы измерения.</typeparam>
public abstract record BaseMeasurement<T, U, E>(T Value, U Measure) : IMeasurement<T, U, E> where T : INumberBase<T> where U : IUnits<U, E> where E : struct, Enum;