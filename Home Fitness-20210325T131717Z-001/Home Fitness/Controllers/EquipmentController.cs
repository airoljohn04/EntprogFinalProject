using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Home_Fitness.Data;
using Home_Fitness.Models;

namespace Home_Fitness.Controllers
{
    public class EquipmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EquipmentController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var list = _context.Items.ToList();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Item record)
        {
            var item = new Item();
            item.CustomerName = record.CustomerName;
            item.Code = record.Code;
            item.DescriptionOfEquipment = record.DescriptionOfEquipment;
            item.Price = record.Price;
            item.DateAdded = DateTime.Now;
            item.EquipmentType = record.EquipmentType;

            _context.Items.Add(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if(id==null)
            {
                return RedirectToAction("Index");
            }

            var item = _context.Items.Where(i => i.EquipmentID == id).SingleOrDefault();
            if(item == null)
            {
                return RedirectToAction("Index");
            }

            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(int? id, Item record)
        {
            var item = _context.Items.Where(i => i.EquipmentID == id).SingleOrDefault();
            item.CustomerName = record.CustomerName;
            item.Code = record.Code;
            item.DescriptionOfEquipment = record.DescriptionOfEquipment;
            item.Price = record.Price;
            item.EquipmentType = record.EquipmentType;

            _context.Items.Update(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var item = _context.Items.Where(i => i.EquipmentID == id).SingleOrDefault();
            if (item == null)
            {
                return RedirectToAction("Index");
            }

            _context.Items.Remove(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
