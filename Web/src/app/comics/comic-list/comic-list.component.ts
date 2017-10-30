import { Component, OnInit } from '@angular/core';

import { ComicsService } from '../../shared/comics.service';
import { Comic } from '../../shared/comic';

@Component({
  selector: 'app-comic-list',
  templateUrl: './comic-list.component.html',
  styleUrls: ['./comic-list.component.css']
})

export class ComicListComponent implements OnInit {
    comics: Array<Comic> = [];

    constructor(private comicsService: ComicsService
    ) { }

    ngOnInit() {
      this.comicsService.getComics()
        .subscribe((comics) => {
          this.comics = comics;
        });
    }
}
