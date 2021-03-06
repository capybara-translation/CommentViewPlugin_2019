﻿using System;
using System.Windows.Forms;
using Capybara.CommentView_2017.Models;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using Task = System.Threading.Tasks.Task;

namespace Capybara.CommentView_2017
{
    [ViewPart(
        Id = "ProjectsCommentViewPart",
        Name = "Plugin_Name",
        Description = "Plugin_Description",
        Icon = "CommentViewPlugin_Icon")]
    [ViewPartLayout(typeof(ProjectsController), Dock = DockType.Bottom)]
    public class ProjectsCommentViewPartController : AbstractViewPartController
    {
        private CommentService _commentService;
        protected override void Initialize()
        {
            _commentService = new CommentService();

            var projectController = SdlTradosStudio.Application.GetController<ProjectsController>();
            projectController.SelectedProjectsChanged += async (sender, args) =>
            {
                Control.Value.ShowLoadingProgressBar(true);
                var result = await Task.Run(() =>
                {
                    return _commentService.GetCommentsFromProjects(projectController.SelectedProjects);
                });

                Control.Value.SetContent(result);
                Control.Value.ShowLoadingProgressBar(false);
            };
        }

        protected override Control GetContentControl()
        {
            return Control.Value;
        }

        private static readonly Lazy<ProjectsCommentViewPartControl> Control = new Lazy<ProjectsCommentViewPartControl>(() => new ProjectsCommentViewPartControl());

    }
}