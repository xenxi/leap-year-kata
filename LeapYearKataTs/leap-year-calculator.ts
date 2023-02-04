export class LeapYearCalculator {
  public static isLeap(yearNumber: number): boolean {
    const year = new Year(yearNumber);
    return year.isLeap();
  }
}

class Year {
  constructor(private year: number) {}

  public isLeap(): boolean {
    if (this.isDivisibleBy(100) && !this.isDivisibleBy(400)) return false;
    if (!this.isDivisibleBy(4)) return false;
    return true;
  }

  private isDivisibleBy = (num: number): boolean => this.year % num == 0;
}
