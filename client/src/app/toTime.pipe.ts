import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
    name: 'toTime'
})
export class toTimePipe implements PipeTransform {
    transform(value: number): string {
        if (value < 60)
            return value % 60 + " minutes";
        if (value % 60 == 0)
            return Math.floor(value / 60) + " hours";
        return Math.floor(value / 60) + " hours and " + value % 60 + " minutes";
    }
}