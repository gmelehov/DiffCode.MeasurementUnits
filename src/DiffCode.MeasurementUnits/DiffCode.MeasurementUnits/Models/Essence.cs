using DiffCode.MeasurementUnits.Base;

using System.Numerics;



namespace DiffCode.MeasurementUnits.Models;

/// <summary>
/// <para>Значение с единицей измерения сущности.</para>
/// </summary>
/// <typeparam name="T">Тип значения.</typeparam>
/// <param name="Value">Значение.</param>
/// <param name="Measure">Единица измерения.</param>
public record Essence<T>(T Value, EssenceUnits Measure) : BaseMeasurement<T, EssenceUnits, EssenceMeasure.Unit>(Value, Measure) where T : IUnsignedNumber<T>;
