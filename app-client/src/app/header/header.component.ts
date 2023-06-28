import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MatToolbarModule } from '@angular/material/toolbar';
import { RouterModule } from '@angular/router';
import { AuthenticationService } from '../authentication/services/authentication.service';
import { UserRole } from '../enums/UserRole';

@Component({
  selector: 'app-header',
  standalone: true,
  imports: [CommonModule, RouterModule, MatToolbarModule, FormsModule],
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class HeaderComponent {
  constructor(private authService: AuthenticationService) {}
  search!: string;

  userAuthenticated = this.authService.hasUserAuthenticated();
  assignedRole = this.authService.getUserRole();
  userRole: UserRole = UserRole.Admin;

  logout() {
    this.authService.logout();
  }
}
