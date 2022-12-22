using DiffCode.MeasurementUnits.Base;

using System.Numerics;



namespace DiffCode.MeasurementUnits.Models;

/// <summary>
/// <para>Значение даты/дня.</para>
/// </summary>
/// <typeparam name="T">Тип значения.</typeparam>
/// <param name="Value">Значение.</param>
/// <param name="Measure">Единица измерения.</param>
public record Date<T>(T Value, DateUnits Measure) : BaseMeasurement<T, DateUnits, DateMeasure.Unit>(Value, Measure) where T : IUnsignedNumber<T>;
