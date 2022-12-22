using DiffCode.MeasurementUnits.Base;

using System.Numerics;



namespace DiffCode.MeasurementUnits.Models;


/// <summary>
/// <para>Значение с валютой.</para>
/// </summary>
/// <typeparam name="T">Тип значения.</typeparam>
/// <param name="Value">Значение.</param>
/// <param name="Measure">Единица измерения.</param>
public record Currency<T>(T Value, CurrencyUnits Measure) : BaseMeasurement<T, CurrencyUnits, CurrencyMeasure.Unit>(Value, Measure) where T : INumber<T>;
