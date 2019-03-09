import { MASGlobalWebPage } from './app.po';

describe('masglobal-web App', function() {
  let page: MASGlobalWebPage;

  beforeEach(() => {
    page = new MASGlobalWebPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
