import { RouterModule } from '@angular/router';
import { HeaderComponent } from './header/header.component';
import {Component} from '@angular/core'
import { FooterComponent } from './footer/footer.component';

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  imports: [RouterModule, HeaderComponent, FooterComponent],
})
export class AppComponent {
  title = 'appClient';
  navItems: string[] = ['one', 'two', 'three'];

  selectedItem!: string;

  // constructor(private route: ActivatedRoute) {
  //   this.route.url.subscribe(url => {
  //     this.items = url.map(segment => segment.path);
  //     console.log('this.items: ', this.items);
  //   });
  // }

  onSelected(item: string) {
    this.selectedItem = item;
  }
}
