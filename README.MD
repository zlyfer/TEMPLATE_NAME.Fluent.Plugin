# TEMPLATE_NAME

A [Fluent Search](https://github.com/adirh3/Fluent-Search) app to `TEMPLATE_DESC`.

## Showcase

![Showcase Gif](media/showcase.gif)

## Template Guide

Info: "Replace" means replace in file names and file contents.

### Addon Metadata

- [ ] Replace `TEMPLATE_NAME` with the name of the app.
  - Example: `OpenHeidiSQLProfiles`
  - [ ] `TEMPLATE_NAME` will also be the repo name (https://github.com/zlyfer/TEMPLATE_NAME.Fluent.Plugin).
- [ ] Replace `TEMPLATE_DISPLAYNAME` with the display name of the app.
  - Example: `Open HeidiSQL Profiles`
- [ ] Replace `TEMPLATE_DESC` with the description of the app.
  - Example: `Search and open HeidiSQL database connection profiles.`

### Search

This template has one search result and one search result operation. Adjust following template placeholders to setup the first of each.

- [ ] Replace `TEMPLATE_SEARCH_APP` with the name of the application that the search belongs to.
  - Example: "HeidiSQL"
- [ ] Replace `TEMPLATE_SEARCH_RESULT_NAME` with the class identifier of the search result.
  - Example: `HeidiSQLProfile`
- [ ] Replace `TEMPLATE_SEARCH_RESULT_DISPLAYNAME` with the name of the search result.
  - Example: `HeidiSQL Profile`
- [ ] Replace `TEMPLATE_SEARCH_RESULT_LIST` with the variable name of the list to be searched.
  - Example: `profileName`
  - The list name should hint about what is searched for and should use the singular form (fileName, databaseRow, profileName, etc.).
  - Info: The logic for populating this list has to be implemented.
- [ ] Replace `TEMPLATE_SEARCH_RESULT_OPERATION_NAME` with the action class identifier used for the search result. Example: `OpenProfile`
- [ ] Replace `TEMPLATE_SEARCH_RESULT_OPERATION_DISPLAYNAME` with the name of the search result action.
  - Example: `Open Profile`
- [ ] Replace `TEMPLATE_SEARCH_RESULT_OPERATION_DESC` with the description of the search result action.
  - Example: `Opens the HeidiSQL profile.`
