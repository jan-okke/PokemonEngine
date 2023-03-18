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
		public override List<Ability> AvailableAbilities => new() {new Naturalcure() };
		public override Stats BaseStats => new Stats(100, 100, 100, 100, 100, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Growth() },
			[10] = new List<Move>() { new Magicalleaf() },
			[19] = new List<Move>() { new Leechseed() },
			[28] = new List<Move>() { new Synthesis() },
			[37] = new List<Move>() { new Sweetscent() },
			[46] = new List<Move>() { new Healingwish() },
			[55] = new List<Move>() { new Worryseed() },
			[64] = new List<Move>() { new Aromatherapy() },
			[73] = new List<Move>() { new Energyball() },
			[82] = new List<Move>() { new Sweetkiss() },
			[91] = new List<Move>() { new Healingwish() },
			[100] = new List<Move>() { new Seedflare() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Bulletseed(), new Confide(), new Covet(), new Dazzlinggleam(), new Doubleteam(), new Earthpower(), new Endeavor(), new Endure(), new Energyball(), new Facade(), new Flash(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Hyperbeam(), new Laserfocus(), new Lastresort(), new Naturepower(), new Protect(), new Psychic(), new Psychup(), new Rest(), new Return(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Synthesis(), new Worryseed(), new Zenheadbutt() };
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