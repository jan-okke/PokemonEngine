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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Chlorophyll() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Gluttony() };
		public override Stats BaseStats => new Stats(50, 75, 35, 70, 30, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Vinewhip() },
			[7] = new List<Move>() { new Moves.Growth() },
			[11] = new List<Move>() { new Moves.Wrap() },
			[13] = new List<Move>() { new Moves.Sleeppowder() },
			[15] = new List<Move>() { new Moves.Poisonpowder() },
			[17] = new List<Move>() { new Moves.Stunspore() },
			[23] = new List<Move>() { new Moves.Acid() },
			[27] = new List<Move>() { new Moves.Knockoff() },
			[29] = new List<Move>() { new Moves.Sweetscent() },
			[35] = new List<Move>() { new Moves.Gastroacid() },
			[39] = new List<Move>() { new Moves.Razorleaf() },
			[41] = new List<Move>() { new Moves.Poisonjab() },
			[47] = new List<Move>() { new Moves.Slam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bind(), new Moves.Bulletseed(), new Moves.Confide(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gastroacid(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Infestation(), new Moves.Knockoff(), new Moves.Naturepower(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Thief(), new Moves.Venoshock(), new Moves.Worryseed() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Acidspray(), new Moves.Belch(), new Moves.Clearsmog(), new Moves.Encore(), new Moves.Ingrain(), new Moves.Leechlife(), new Moves.Magicalleaf(), new Moves.Powerwhip(), new Moves.Strengthsap(), new Moves.Synthesis(), new Moves.Tickle(), new Moves.Weatherball(), new Moves.Worryseed() };
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