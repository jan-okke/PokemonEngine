using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Bellsprout : Pokemon
	{
		public override string Name => "Bellsprout";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Gluttony() };
		public override Stats BaseStats => new Stats(50, 75, 35, 70, 30, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Vinewhip() },
			[7] = new List<Move>() { new Growth() },
			[11] = new List<Move>() { new Wrap() },
			[13] = new List<Move>() { new Sleeppowder() },
			[15] = new List<Move>() { new Poisonpowder() },
			[17] = new List<Move>() { new Stunspore() },
			[23] = new List<Move>() { new Acid() },
			[27] = new List<Move>() { new Knockoff() },
			[29] = new List<Move>() { new Sweetscent() },
			[35] = new List<Move>() { new Gastroacid() },
			[39] = new List<Move>() { new Razorleaf() },
			[41] = new List<Move>() { new Poisonjab() },
			[47] = new List<Move>() { new Slam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bind(), new Bulletseed(), new Confide(), new Cut(), new Doubleteam(), new Endure(), new Energyball(), new Facade(), new Flash(), new Frustration(), new Gastroacid(), new Gigadrain(), new Grassknot(), new Hiddenpower(), new Infestation(), new Knockoff(), new Naturepower(), new Poisonjab(), new Protect(), new Reflect(), new Rest(), new Return(), new Round(), new Seedbomb(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Synthesis(), new Thief(), new Venoshock(), new Worryseed() };
		public override List<Move> EggMoves => new List<Move>() { new Acidspray(), new Belch(), new Clearsmog(), new Encore(), new Ingrain(), new Leechlife(), new Magicalleaf(), new Powerwhip(), new Strengthsap(), new Synthesis(), new Tickle(), new Weatherball(), new Worryseed() };
		public override int Weight => 40;
		public override int ExpYield => 60;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}