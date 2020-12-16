using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GameView
{
    public class Drawer
    {
        private readonly Canvas canvas;
        public Drawer(Canvas canvas)
        {
            this.canvas = canvas;
            NameScope.SetNameScope(canvas, new NameScope());
        }

        public void DrawImage(string source, string id, double width, double height, double x, double y)
        {
            Uri uri = new Uri(source, UriKind.Relative);
            BitmapImage bitmapImage = new BitmapImage(uri);
            Image image = new Image
            {
                Source = bitmapImage,
                Width = width,
                Height = height,
                Name = id
            };
            canvas.Children.Add(image);
            Canvas.SetLeft(image, x);
            Canvas.SetTop(image, y);
        }

        public void DrawLine(string id, double x1, double y1, double x2, double y2, double thickness)
        {
            Line line = new Line
            {
                Name = id,
                X1 = x1,
                Y1 = y1,
                X2 = x2,
                Y2 = y2,
                StrokeThickness = thickness,
                StrokeStartLineCap = PenLineCap.Round,
                StrokeEndLineCap = PenLineCap.Round,
                Stroke = Brushes.Black
            };
            canvas.Children.Add(line);
        }

        public void DrawRectangle(string id, double x, double y, double width, double height, int zIndex)
        {
            Rectangle rectangle = new Rectangle
            {
                Name = id,
                Width = width,
                Height = height,
                Stroke = Brushes.Black,
                Fill = Brushes.SkyBlue,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
            };
            // Required if object is expected to move with an animation
            canvas.RegisterName(id, rectangle);
            canvas.Children.Add(rectangle);
            Canvas.SetLeft(rectangle, x);
            Canvas.SetTop(rectangle, y);
            Canvas.SetZIndex(rectangle, zIndex);
        }

        public void DrawText(string id, string text, double x, double y, double width, double height, int zIndex)
        {
            TextBlock textBlock = new TextBlock
            {
                Name = id,
                Text = text,
                TextAlignment = TextAlignment.Center,
                Width = width,
                Height = height,
                Background = Brushes.AntiqueWhite,
                Foreground = Brushes.Navy,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
            };
            canvas.Children.Add(textBlock);
            Canvas.SetLeft(textBlock, x);
            Canvas.SetTop(textBlock, y);
            Panel.SetZIndex(textBlock, zIndex);
        }

        public void DrawEllipse(string id, double x, double y, double width, double height, int zIndex)
        {
            Ellipse ellipse = new Ellipse
            {
                Name = id,
                Width = width,
                Height = height,
                Stroke = Brushes.Black,
                Fill = Brushes.Black,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
            };
            canvas.RegisterName(id, ellipse);
            canvas.Children.Add(ellipse);
            Canvas.SetLeft(ellipse, x);
            Canvas.SetTop(ellipse, y);
            Panel.SetZIndex(ellipse, zIndex);
        }

        public void RemoveObject(string id)
        {
            foreach (FrameworkElement uiObject in canvas.Children)
            {
                if (uiObject.Name == id)
                {
                    canvas.Children.Remove(uiObject);
                    return;
                }
            }
        }

        // TODO: fix moving lines.
        public void MoveObject(string id, double newX, double newY, double transitionDuration)
        {
            object targetObject = LogicalTreeHelper.FindLogicalNode(canvas, id);
            if (targetObject is UIElement)
            {
                UIElement target = targetObject as UIElement;
                Storyboard story = new Storyboard();

                double oldX = Canvas.GetLeft(target);
                double oldY = Canvas.GetTop(target);

                DoubleAnimation animationX = new DoubleAnimation();
                animationX.From = oldX;
                animationX.To = newX;
                animationX.Duration = new Duration(TimeSpan.FromMilliseconds(transitionDuration));

                DoubleAnimation animationY = new DoubleAnimation();
                animationY.From = oldY;
                animationY.To = newY;
                animationY.Duration = animationX.Duration;

                story.Children.Add(animationX);
                Storyboard.SetTargetName(animationX, id);
                Storyboard.SetTargetProperty(animationX, new PropertyPath(Canvas.LeftProperty));

                story.Children.Add(animationY);
                Storyboard.SetTargetName(animationY, id);
                Storyboard.SetTargetProperty(animationY, new PropertyPath(Canvas.TopProperty));

                story.Begin(canvas);
            }

        }
    }
}
