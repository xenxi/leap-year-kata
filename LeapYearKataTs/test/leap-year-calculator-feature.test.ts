import { LeapYearCalculator } from "../leap-year-calculator";

//todo: Todos los años divisibles por 400 SON años bisiestos (así, por ejemplo, 2000 fue un año bisiesto),
//todo: Todos los años divisibles por 100 pero no por 400 NO son años bisiestos (por ejemplo, 1700, 1800 y 1900 NO fueron años bisiestos, NI 2100 será un año bisiesto),
//todo: Todos los años divisibles por 4 pero no por 100 SON años bisiestos (por ejemplo, 2008, 2012, 2016),
//todo: Todos los años que no son divisibles por 4 NO son bisiestos (por ejemplo, 2017, 2018, 2019).

describe("LeapYearCalculator should", () => {
  test("identify a year as a leap year if it is divisible by 400", () => {
    const yearMultipleOf400 = 2000;

    const isLeapYear = LeapYearCalculator.isLeap(yearMultipleOf400);

    expect(isLeapYear).toBeTruthy();
  });
  test.each([2017, 2018, 2019])(
    "identify %s as a non-leap year if git it is not divisible by 4",
    (yearNoMultipleOf4: number) => {
      const isLeapYear = LeapYearCalculator.isLeap(yearNoMultipleOf4);

      expect(isLeapYear).toBeFalsy();
    }
  );
});
