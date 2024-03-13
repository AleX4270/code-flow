import { Routes } from '@angular/router';
import { BoardComponent } from "./board/board.component";
import { StartPageComponent } from "./start-page/start-page.component";

export const routes: Routes = [
    { path: '', component: StartPageComponent },
    { path: 'board', component: BoardComponent }
];
