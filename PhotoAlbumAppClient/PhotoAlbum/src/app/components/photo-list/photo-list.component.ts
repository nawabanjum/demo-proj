import { Component, OnInit } from '@angular/core';
import { PhotoService } from '../../services/photo.service';

@Component({
  selector: 'app-photo-list',
  templateUrl: './photo-list.component.html'
})
export class PhotoListComponent implements OnInit {
  photos: any[] = [];
  constructor(private photoService: PhotoService) { }

  ngOnInit(): void {
    debugger
    this.photoService.getPhotosByAlbumId(3).subscribe((data: any) => {
      this.photos = data;
    });
  }
}
  