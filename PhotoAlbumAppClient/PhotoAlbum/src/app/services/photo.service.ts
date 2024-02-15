import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PhotoService {
  private apiUrl = 'https://jsonplaceholder.typicode.com/photos';

  constructor(private http: HttpClient) { }

  getPhotosByAlbumId(albumId: number) {
    return this.http.get(`${this.apiUrl}?albumId=${albumId}`);
  }
}
