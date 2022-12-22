using DiffCode.MeasurementUnits.Base;
using DiffCode.MeasurementUnits.Models;

using System.ComponentModel.DataAnnotations;
using System.Numerics;



namespace DiffCode.MeasurementUnits.Extensions;


/// <summary>
/// <para>Методы расширения для <see cref="INumberBase{T}"/>.</para>
/// </summary>
public static class NumberExtensions
{




  public static Time<T> ToTime<T>(this T number, TimeUnits units) where T : IUnsignedNumber<T> => new(number, units);

  public static Time<T> Minutes<T>(this T number) where T : IUnsignedNumber<T> => new(number, TimeUnits.Minute);

  public static Time<T> Hours<T>(this T number) where T : IUnsignedNumber<T> => new(number, TimeUnits.Hour);

  public static Time<T> Days<T>(this T number) where T : IUnsignedNumber<T> => new(number, TimeUnits.Day);

  public static Time<T> WorkDays<T>(this T number) where T : IUnsignedNumber<T> => new(number, TimeUnits.WorkDay);

  public static Time<T> CalendDays<T>(this T number) where T : IUnsignedNumber<T> => new(number, TimeUnits.CalendDay);

  public static Time<T> Weeks<T>(this T number) where T : IUnsignedNumber<T> => new(number, TimeUnits.Week);

  public static Time<T> Months<T>(this T number) where T : IUnsignedNumber<T> => new(number, TimeUnits.Month);

  public static Time<T> Quarters<T>(this T number) where T : IUnsignedNumber<T> => new(number, TimeUnits.Quarter);

  public static Time<T> Years<T>(this T number) where T : IUnsignedNumber<T> => new(number, TimeUnits.Year);




  public static Date<T> ToDate<T>(this T number, DateUnits units) where T : IUnsignedNumber<T> => new(number, units);

  public static Date<T> DayOfWeek<T>(this T number) where T : IUnsignedNumber<T> => new(number, DateUnits.DayOfWeek);

  public static Date<T> DayOfMonth<T>(this T number) where T : IUnsignedNumber<T> => new(number, DateUnits.DayOfMonth);







  public static Currency<T> ToCurrency<T>(this T number, CurrencyUnits units) where T : INumber<T> => new(number, units);

  public static Currency<T> Roubles<T>(this T number) where T : INumber<T> => new(number, CurrencyUnits.Rouble);

  public static Currency<T> Dollars<T>(this T number) where T : INumber<T> => new(number, CurrencyUnits.Dollar);

  public static Currency<T> Euros<T>(this T number) where T : INumber<T> => new(number, CurrencyUnits.Euro);



}