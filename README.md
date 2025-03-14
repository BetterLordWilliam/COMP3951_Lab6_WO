# COMP3951_Lab6_WO

## Requirement 1
Done 

## Requirement 2
Done

## Requirement 3 Ideasd
Some thoughts about what to do for requirement 3 of the lab.

- Custom Control, toolbar item, representing the current BestFile.
    - Or adjacent to this a toolbar item which extends a combo-box and shows the resource files that are linked to the current bestfile.
- Custom User Control, Markdown Editor Pane
    - Nested toolbar controls
    - Rich text editor
    - Event for editing the text in the rich text editor.

Control, file selector
User Control, markdown editor

Demo application --> Have the selector select a file from a list of files that hte user can add into the application

When they select a file it is opnened in the custom user control, the custom user control overrides the text changed event to notify the UI that the files in the current editor pane is being edited. This will enable a save button so that the user can write the changes in the file to the file system.

| ℹ️ | This is a wokring version on windows forms and not exactly how it would be implemented in MAUI, however the concept is similar |
| --- | ------------------------------------------------------------------------------------------------------------------------------ |


**Will Implement these in winforms for the purpose of the lab and then again in MAUI**

- Will Otterbein, 2025/3/12