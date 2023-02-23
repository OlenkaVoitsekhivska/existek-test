import { Component } from '@angular/core';
import categories from './../../../../assets/categories.json';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
})
export class SidebarComponent {
  checked = false;
  categoriesList = [...categories].slice(0, 6);

  checkboxGroup = [
    { id: 1, range: '0 - $5', checked: false },
    { id: 2, range: '$5 - $10', checked: false },
    { id: 3, range: '$10 - $20', checked: false },
    { id: 4, range: '$20 - $50', checked: false },
    { id: 5, range: '$50 - $100', checked: false },
  ];
}
