import { InMemoryDbService } from '../../node_modules/angular-in-memory-web-api';

export class InMemoryDataService implements InMemoryDbService {
  createDb() {
    const mottoes = [
      { mottoId: 1, sentence: 'elo mordo' },
      { mottoId: 2, sentence: 'elo mordo 2' }
    ];

    return mottoes;
  }
}
