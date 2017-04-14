import { GenebygenePage } from './app.po';

describe('genebygene App', () => {
  let page: GenebygenePage;

  beforeEach(() => {
    page = new GenebygenePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
