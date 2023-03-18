using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Shaymin : Pokemon
	{
		public override string Name => "Shaymin";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Naturalcure() };
		public override Stats BaseStats => new Stats(100, 100, 100, 100, 100, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Growth() },
			[10] = new List<Move>() { new Moves.Magicalleaf() },
			[19] = new List<Move>() { new Moves.Leechseed() },
			[28] = new List<Move>() { new Moves.Synthesis() },
			[37] = new List<Move>() { new Moves.Sweetscent() },
			[46] = new List<Move>() { new Moves.Healingwish() },
			[55] = new List<Move>() { new Moves.Worryseed() },
			[64] = new List<Move>() { new Moves.Aromatherapy() },
			[73] = new List<Move>() { new Moves.Energyball() },
			[82] = new List<Move>() { new Moves.Sweetkiss() },
			[91] = new List<Move>() { new Moves.Healingwish() },
			[100] = new List<Move>() { new Moves.Seedflare() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Bulletseed(), new Moves.Confide(), new Moves.Covet(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Endeavor(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Laserfocus(), new Moves.Lastresort(), new Moves.Naturepower(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Worryseed(), new Moves.Zenheadbutt() };
		public override int Weight => 21;
		public override int ExpYield => 300;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 3,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}