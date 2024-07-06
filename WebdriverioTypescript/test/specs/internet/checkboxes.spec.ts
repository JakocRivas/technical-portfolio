import { expect } from '@wdio/globals';
import checkboxes from '../../../page-objects/checkboxes.page.js';

describe('Scenario: internet heroku', () => {
  describe('Feature: checkboxes', () => {
    before(async function () {
      await checkboxes.open();
      (await checkboxes.checkboxesLink).waitForDisplayed();
    });

    describe('Given: user navigates to the internet heroku page', () => {
      describe('When: user clicks checkboxes link', () => {
        it('Then: User should be redirected to checkboxes page', async () => {
          await checkboxes.checkboxesLink.click();
          await checkboxes.checkbox.waitForExist();
          await expect(await checkboxes.checkbox).toBeDisplayed();
        });
      });

      describe('When: user clicks checkboxe', () => {
        it('Then: checkbox should be enabled', async () => {
          await checkboxes.checkbox.click();
          await expect(await checkboxes.checkbox).toBeSelected();
        });
      });
    });
  });
});
